using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerKatmanli.BLL
{
    public interface IRepository<T>//t benım classım ınterface de ozellık tanımlıyıcam ılk yapmam gereken burası
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
        List<T> SelectAll();
        T SelectById(int itemId); 
    }
}
