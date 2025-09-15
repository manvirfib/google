public class Twitter {
    private const int MAX_FEED_SIZE = 10;

    // Store tweets per user (keep last MAX_FEED_SIZE)
    private readonly Dictionary<int, LinkedList<(int tweetId, int time)>> postsPerUser;
    // Store follow relationships (no duplicates)
    private readonly Dictionary<int, HashSet<int>> listOfUsers;
    // Track time for ordering tweets globally
    private int time;

    public Twitter() {
        postsPerUser = new Dictionary<int, LinkedList<(int, int)>>();
        listOfUsers = new Dictionary<int, HashSet<int>>();
        time = 0;
    }

    private void EnsureUser(int userId) {
        if (!postsPerUser.ContainsKey(userId))
            postsPerUser[userId] = new LinkedList<(int, int)>();

        if (!listOfUsers.ContainsKey(userId)) {
            listOfUsers[userId] = new HashSet<int>();
            listOfUsers[userId].Add(userId); // self-follow so user sees own tweets
        }
    }

    public void PostTweet(int userId, int tweetId) {
        EnsureUser(userId);
        var postList = postsPerUser[userId];
        postList.AddLast((tweetId, time++));

        // Keep only last MAX_FEED_SIZE tweets
        if (postList.Count > MAX_FEED_SIZE)
            postList.RemoveFirst();
    }

    public List<int> GetNewsFeed(int userId) {
        if (!listOfUsers.ContainsKey(userId))
            return new List<int>();

        var pq = new PriorityQueue<(int tweetId, int time), int>();

        foreach (var followee in listOfUsers[userId]) {
            if (!postsPerUser.ContainsKey(followee)) continue;

            foreach (var post in postsPerUser[followee]) {
                pq.Enqueue(post, post.time);
                if (pq.Count > MAX_FEED_SIZE) pq.Dequeue(); // keep PQ small
            }
        }

        var result = new LinkedList<int>();
        while (pq.Count > 0)
            result.AddFirst(pq.Dequeue().tweetId);

        return new List<int>(result);
    }

    public void Follow(int followerId, int followeeId) {
        EnsureUser(followerId);
        EnsureUser(followeeId);
        listOfUsers[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId) {
        if (!listOfUsers.ContainsKey(followerId) || followerId == followeeId)
            return;
        listOfUsers[followerId].Remove(followeeId);
    }
}
