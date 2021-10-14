using System;

namespace scraping
{
    public class JSONStore
    {
        public JSONStore() { }

        public string get(int id)
        {
            // return a raw json string for data at this ID
        }

        public void insert(string jsonData, int id)
        {
            // insert data into dataStore with the id
        }

        public void update(string jsonData, int id)
        {
            // update data at the id in the datastore
        }

        public void delete(int id)
        {
            // remove data at the id in the datastore
        }
    }

}