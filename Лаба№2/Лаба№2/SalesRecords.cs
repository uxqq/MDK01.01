
namespace Лаба_2
{
    public class SalesRecords
    {

        private int day_;
        private Film film_;

        public SalesRecords(int day, Film film)
        {
            day_ = day;
            film_ = film;
        }

        public int GetDay()
        {
            return day_;
        }

        public Film GetFilm()
        {
            return film_;
        }
    }
}
