using efcore.demo;
using Microsoft.EntityFrameworkCore;


using (var db = new DefaultDbContext())
{
    
    // init data
    var insertLogs = new List<AppLoginLog>()
    {
        new AppLoginLog()
        {
            UserId = 1, UserIP = "127.0.0.1",
            CreationTime = DateTime.Parse("2023-02-01 12:30:00")
        },
        new AppLoginLog()
        {
            UserId = 1, UserIP = "127.0.0.1",
            CreationTime = DateTime.Parse("2023-02-01 12:00:00")
        },
        new AppLoginLog()
        {
            UserId = 2, UserIP = "127.0.0.1",
            CreationTime = DateTime.Parse("2023-02-02 12:00:00")
        },
    };
    await db.AppLoginLogs.AddRangeAsync(insertLogs);
    await db.SaveChangesAsync();
    // end Init Data

    // first query count
    var count = await db.AppLoginLogs.CountAsync(x => x.UserId == 1 && x.CreationTime >= DateTime.Now.AddDays(-10) &&
                                                      x.CreationTime <= DateTime.Now);

    // throw an Error : Packet received out-of-order. Expected 1; got 2
    var logs = await db.AppLoginLogs.Where(x => x.UserId == 1 && x.CreationTime >= DateTime.Now.AddDays(-10) &&
                                                x.CreationTime <= DateTime.Now).ToListAsync();
}


Console.ReadKey();