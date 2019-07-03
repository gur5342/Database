using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step4.Data
{
    public class PlaylistData
    {
        public int GetCount(string keyword)
        {
            using (var context = new ChinookEntities())
            {

                var query = from x in context.Tracks
                            from y in context.InvoiceLines
                            where x.Composer.Contains(keyword) && x.TrackId == y.TrackId
                            select x.UnitPrice;

                return query.Count();
            }
        }

        public List<Track> GetGenre(string keyword) // 
        {
            using (var context = new ChinookEntities())
            {
                context.Database.Log = PrintToDebug;

                var query = from x in context.Tracks
                            from y in context.InvoiceLines
                            where x.Composer.Contains(keyword) && x.TrackId == y.TrackId
                            orderby x.Composer
                            select x;


                return query.ToList();
            }
        }

        private void PrintToDebug(string log)
        {
           // Debug.WriteLine(log);
        }
    }
}
