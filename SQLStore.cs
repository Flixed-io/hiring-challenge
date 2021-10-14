using System;

namespace scraping
{
    public class SQLStore
    {
        public SQLStore() { }
        /**
        * Executes the given query as a SQL command.
        *
        * query: the SQL query. The SQL string must not be ; terminated
        * sqlVars: ?s in the where clause of the above query, will be replaced by the values from sqlVars. The values will be bound as Strings.
        */
        public object rawQuery(string query, string[] sqlVars)
        {
            // rawQuery is passed strings to execute sql commands
            // sqlVars will be subbed into query to replace any ?

            // examples:
            //
            // get
            // sqlStore.rawQuery("select * from movies where id=?", new[]{"iron-man_2008"});
            //
            // insert
            // sqlStore.rawQuery("insert into movies (id, name, year, description) values (?, ?, ?)", new[]{"iron-man_2008", "Iron Man", "2008", "A billionaire and genius inventor, Tony Stark, is conducting weapons tests overseas..."});
            // sqlStore.rawQuery("insert into movies_streaming_service (streaming_service_id, movie_id) values (?, ?, ?)", new[]{"iron-man_2008", "netflix"});
            //
            // update
            // sqlStore.rawQuery("update movies set description=? where id = ?", new[]{"A billionaire Tony Stark gets kidnapped...", "iron-man_2008"});
            //
            // delete
            // sqlStore.rawQuery("delete from movies where id=?", new[]{"iron-man_2008"});
        }
    }

}