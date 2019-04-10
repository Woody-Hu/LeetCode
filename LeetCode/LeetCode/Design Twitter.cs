using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Twitter
    {

        Dictionary<int, List<int>> followers;
        List<Tweet> tweets;

        private class Tweet
        {
            internal int UID;
            internal int TweetId;
            public Tweet(int uid, int tweetId)
            {
                this.UID = uid;
                this.TweetId = tweetId;
            }

        }

        public Twitter()
        {
            tweets = new List<Tweet>();
            followers = new Dictionary<int, List<int>>();
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            tweets.Add(new Tweet(userId, tweetId));
        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            var userIds = new HashSet<int>();
            userIds.Add(userId);
            if (followers.ContainsKey(userId))
            {
                foreach (var oneUserId in followers[userId])
                {
                    userIds.Add(oneUserId);
                }
            }

            var count = 10;
            var list = new List<int>();
            for (int i = tweets.Count - 1; i >= 0 && count > 0; i--)
            {
                if (userIds.Contains(tweets[i].UID))
                {
                    list.Add(tweets[i].TweetId);
                    count--;
                }
            }

            return list;
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {

            if (!followers.ContainsKey(followerId))
            {
                followers.Add(followerId, new List<int>());
            }

            followers[followerId].Add(followeeId);

        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (followers.ContainsKey(followerId))
            {
                followers[followerId].Remove(followeeId);
            }
        }
    }
}
