using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    namespace FinalProject
    {
        class Uploadservice
        {
            private Uploadservice() { }

            public int id { get; private set; }

            private static Uploadservice _instance;

            private static readonly _lock = new object ()

            public static Uploadservice Instance(int id)
            {
                if (_instance == null)
                {

                    lock (_lock)
                    {
                        if (_Instance == null)
                        {
                            _instance = new Uploadservice();
                            _instance.id = id;
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
