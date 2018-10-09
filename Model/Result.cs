using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{

    public class Result
    {
        /// <summary>
        /// information about internal exception
        /// </summary>

        public Exception ExceptionInfo { get; set; }

        /// <summary>
        /// true if operation completed successfully
        /// </summary>

        public bool IsSuccess { get; set; }

        /// <summary>
        /// a code indicating the operation result detail (internally ResultCode = 0 => Success = true but this is not granted)
        /// </summary>

        public int ResultCode { get; set; }

        /// <summary>
        /// an information message about operation
        /// </summary>

        public string ResultMessage { get; set; }

        public Result()
        {
            ResultMessage = string.Empty;
            ExceptionInfo = new Exception();
        }
    }

    /// <summary>
    /// Stores any Type of object in Result as its Value
    /// </summary>
    /// <typeparam name="T">Any type</typeparam>

    public class Result<T> : Result
    {

        public T Value { get; set; }
    }
}
