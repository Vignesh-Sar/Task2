using System;

namespace dataannotations.Models
{
    public interface IRepository
    {
        public void AddData(Data data);
        public IEnumerable<Data> GetData();
    }
}