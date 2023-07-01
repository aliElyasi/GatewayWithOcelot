using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Writer.Api.Models;
namespace Writer.Api.Services
{
    public class WriterService
    {
        private List<Models.Writer> _Writers = GetDefaultWriterData();

        private static List<Models.Writer> GetDefaultWriterData()
        {

            return new List<Models.Writer>()
            {
                new Models.Writer(){Id=1,Name="test1"},
                new Models.Writer(){Id=2,Name="test2"},
                new Models.Writer(){Id=3,Name="test3"}

            };
        }

        public void AddWriter(Models.Writer writer)
        {
            _Writers.Add(writer);


        }

    }
}