
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Native;
using DevExpress.Web.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.DxDashboardSample
{
	/// <summary>
	/// Provides a replacement for the default DevExpress Dashboard Controller.
	/// </summary>
	public class DashboardHelper
	{
		private AdaptersFactory factory;

		/// <summary>
		/// Creates a new instance of <see cref="DashboardHelper"/> with the given configurator.
		/// </summary>
		/// <param name="configurator"></param>
		public DashboardHelper(DashboardConfigurator configurator)
		{
			var secureDataConverter = new WisejSecureDataConverter();
			this.factory = new AdaptersFactory(
				true, 
				configurator, 
				new WisejJsonSerializer(), 
				secureDataConverter, 
				new DataSourceProtectorService(secureDataConverter));
		}

		/// <summary>
		/// Processes the given Dashboard WebRequest.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ProcessRequest(object sender, WebRequestEventArgs e)
		{
			var serviceUrl = ((IWisejHandler)sender).GetServiceURL();
			var payload = e.Request.Url.AbsolutePath.Substring(serviceUrl.Length + 1);
			
			var parts = payload.Split(new string[] { "/" }, System.StringSplitOptions.RemoveEmptyEntries);
			var action = parts.First() ?? "";
			switch (action)
			{
				case "dashboards":
					e.Response.ContentType = "application/json";
					e.Response.Write(ProcessDashboards(e.Request, parts));
					break;

				case "data":
					e.Response.ContentType = "application/json";
					e.Response.Write(ProcessData(e, parts));
					break;

				case "dataSources":
					e.Response.Write(GetDataSources());
					break;

				default:
					break;
			}
		}

		private string ProcessDashboards(HttpRequest request, string[] payload)
		{
			if (payload.Count() > 1)
			{
				var dashboardId = payload[1];

				if (request.RequestType == "GET")
					return GetDashboard(dashboardId);
				else
					return SaveDashboard(request, dashboardId);
			}	
			else
			{
				if (request.RequestType == "GET")
					return GetDashboards();
				else
					return CreateNewDashboard(request);
			}
		}

		private string ProcessData(WebRequestEventArgs e, string[] payload)
		{
			switch (payload[1])
			{
				case "GetDashboardPaletteAction":
					return GetDashboardPaletteAction(e.Request);

				case "GetColoringSchemeAction":
					return GetColoringSchemeAction(e.Request);

				case "DashboardItemGetAction":

					if (e.Request.RequestType == "GET")
						return GetItemModel(e.Request);
					else
						return PostItemModel(e.Request);

				case "DashboardItemBatchGetAction":
					return GetBatchItemModel(e.Request);

				case "GetConnectionStringsAction":
					return GetConnectionStrings();

				case "FieldListAction":
					return GetFieldList(e.Request);

				case "PerformExportAction":
					return PerformExport(e);

				case "GetMapShapeFileAction":
					return GetMapShapeFileAction(e.Request);

				case "ConvertItemAction":
					return ConvertItem(e.Request);

				case "DataSourceWizardAction":
					return DataSourceWizardAction(e.Request);

				case "DimensionUniqueValuesAction":
					return GetDimensionUniqueValues(e.Request);

				case "DimensionFilterStringAction":
					return GetDimensionFilterString(e.Request);

				case "DimensionFilterItemsAction":
					return GetDimensionFilterItems(e.Request);

				case "ParameterValuesAction":

					if (e.Request.RequestType == "GET")
						return GetParameterValues(e.Request);
					else
						return PostParameterValues(e.Request);

				default:
					return "";
			}
		}

		private string ConvertItem(HttpRequest request)
		{
			return this.factory.CreateDesignerReadyDataServiceAdapter().GetConvertedItem(GetRequestBody(request));
		}

		private string CreateNewDashboard(HttpRequest request)
		{
			return this.factory.CreateDashboardStorageAdapter().CreateNewDashboard(GetRequestBody(request));
		}

		private string DataSourceWizardAction(HttpRequest request)
		{
			return this.factory.CreateDataSourceWizardAdapter().Execute(GetRequestBody(request));
		}

		private string GetBatchItemModel(HttpRequest request)
		{
			return this.factory.CreateDataServiceAdapter().GetItemBatchData(GetQueryParams(request));
		}

		private string GetConnectionStrings()
		{
			return this.factory.CreateDataSourceWizardAdapter().GetConnectionStrings();
		}

		private string GetDashboard(string dashboardId)
		{
			return this.factory.CreateDashboardStorageAdapter().LoadDashboard(dashboardId);
		}

		private string GetDashboards()
		{
			return this.factory.CreateDashboardStorageAdapter().GetDashboards();
		}

		private string GetDataSources()
		{
			return this.factory.CreateDataSourceRepositoryAdapter().GetDataSources();
		}

		private string GetDimensionFilterItems(HttpRequest request)
		{
			return this.factory.CreateDesignerReadyDataServiceAdapter().GetDimensionFilterItems(GetRequestBody(request));
		}

		private string GetDimensionFilterString(HttpRequest request)
		{
			return this.factory.CreateDesignerReadyDataServiceAdapter().GetDimensionFilterString(GetRequestBody(request));
		}

		private string GetDimensionUniqueValues(HttpRequest request)
		{
			return this.factory.CreateDesignerReadyDataServiceAdapter().GetDimensionUniqueValues(GetRequestBody(request));
		}

		private string GetFieldList(HttpRequest request)
		{
			return this.factory.CreateDesignerReadyDataServiceAdapter().GetFieldList(GetRequestBody(request));
		}

		private string GetItemModel(HttpRequest request)
		{
			return this.factory.CreateDataServiceAdapter().GetItemData(GetQueryParams(request));
		}

		private string GetMapShapeFileAction(HttpRequest request)
		{
			return this.factory.CreateDataServiceAdapter().GetMapShapeFile(GetQueryParams(request));
		}

		private string GetParameterValues(HttpRequest request)
		{
			return this.factory.CreateDataServiceAdapter().GetParameterValues(GetQueryParams(request));
		}

		private string PostParameterValues(HttpRequest request)
		{
			return factory.CreateDataServiceAdapter().GetParameterValues(GetRequestBody(request));
		}

		private string GetDashboardPaletteAction(HttpRequest request)
		{
			return factory.CreateDesignerReadyDataServiceAdapter().GetDashboardPalette(GetRequestBody(request));
		}

		private string GetColoringSchemeAction(HttpRequest request)
		{
			return factory.CreateDesignerReadyDataServiceAdapter().GetColoringScheme(GetRequestBody(request));
		}

		private string PostItemModel(HttpRequest request)
		{
			return factory.CreateDataServiceAdapter().GetItemData(GetRequestBody(request));
		}

		private string PerformExport(WebRequestEventArgs e)
		{
			var str = Uri.UnescapeDataString(e.Request.Form["dx-db-export"]);
			var exportData = this.factory.CreateDataServiceAdapter().GetExportData(str, new ExportUriResolver(), new Func<string, string>(HttpUtils.GetContentType));

			exportData.Stream.CopyTo(e.Response.OutputStream);

			e.Response.AppendHeader("content-disposition", $"attachment; filename={exportData.FileName}.{exportData.FileFormat}");
			e.Response.ContentType = exportData.ContentType;

			return "";
		}

		private string SaveDashboard(HttpRequest request, string dashboardId)
		{
			return this.factory.CreateDashboardStorageAdapter().SaveDashboard(dashboardId, GetRequestBody(request));
		}

		private Dictionary<string, string> GetQueryParams(HttpRequest request)
		{
			return request.QueryString.AllKeys.ToDictionary<string, string, string>((string key) => key, (string value) => request.QueryString[value]);
		}

		private string GetRequestBody(HttpRequest request)
		{
			var end = "";
			var inputStream = request.InputStream;

			using (var reader = new StreamReader(inputStream))
				end = reader.ReadToEndAsync().Result;

			return end;
		}
	}
}