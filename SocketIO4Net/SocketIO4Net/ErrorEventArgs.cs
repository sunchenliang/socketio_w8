using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Web;

namespace SocketIOClient
{
	public class ErrorEventArgs : EventArgs
	{
		
		//public string Message { get; set; }
		public Exception Exception { get; set; }
        public WebErrorStatus ErrorStatus { get; set; }

        public ErrorEventArgs(WebErrorStatus webErrorStatus)
            : base()
		{
            this.ErrorStatus = webErrorStatus;
		}
        public ErrorEventArgs(WebErrorStatus webErrorStatus, Exception exception)
            : base()
		{
            this.ErrorStatus = webErrorStatus;
			this.Exception = exception;
		}


	}
}
