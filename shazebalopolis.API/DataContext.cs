using Microsoft.EntityFrameworkCore;
using shazebs.api.Models; 

namespace shazebs.api
{
    public class DataContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public IQueryable<Tweet> ReadAllTweetsFromDb()
        {
            return Tweets;
        }

        public IQueryable<Tweet> ReadOneTweet(long key)
        {
            IQueryable<Tweet> entity = Tweets.Where(x => x.TweetId == key);
            return entity;
        }

        public async Task<Tweet> InsertTweetIntoDb(Tweet entity)
        {
            try
            {
                Tweets.Add(entity);
                await SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return entity;
        }
    }
}