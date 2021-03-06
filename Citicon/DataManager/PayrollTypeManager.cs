﻿using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;

namespace Citicon.DataManager
{
    public static class PayrollTypeManager
    {
        static PayrollTypeManager()
        {
            _Source = new Dictionary<ushort, PayrollType>();
        }

        private static readonly Dictionary<ushort, PayrollType> _Source;

        public static PayrollType GetById(ushort id)
        {
            if (id > 0)
            {
                if (_Source.ContainsKey(id))
                {
                    return _Source[id];
                }
                else
                {
                    using (var process = new GetPayrollTypeById(id))
                    {
                        var result = process.Execute();

                        if (result != null)
                        {
                            _Source.Add(id, result);
                        }

                        return result;
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
