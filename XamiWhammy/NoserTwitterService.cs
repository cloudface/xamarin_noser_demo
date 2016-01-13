using System;
using System.Net;
using System.Net.Http;

namespace XamiWhammy
{
	public class NoserTwitterService : NoserService
	{
		HttpClient httpClient;

		public NoserTwitterService ()
		{
			httpClient = new HttpClient ();
			httpClient.MaxResponseContentBufferSize = 256000;
		}

		public void fetchString(){
			string url = "http://ajax.googleapis.com/ajax/services/search/web?v=1.0&rsz=8&q=";

			//See: https://developer.xamarin.com/guides/xamarin-forms/web-services/consuming/rest/ for info on how to use HttpClient

		}
	}
}

