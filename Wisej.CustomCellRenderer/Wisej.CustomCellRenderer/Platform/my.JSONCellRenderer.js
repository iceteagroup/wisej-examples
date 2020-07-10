

qx.Class.define("my.JSONCellRenderer", {

	extend: wisej.web.datagrid.cellRenderer.Cell,

	members: {

		/**
		 * Returns the value to render inside the cell.
		 *
		 * This method may be overridden by sub classes.
		 *
		 * @param cellInfo {Map} The information about the cell.
		 *          See {@link qx.ui.table.cellrenderer.Abstract#createDataCellHtml}.
		 */
		_getCellValue: function (cellInfo) {

			var jsonObj = JSON.parse(cellInfo.value);

			return "<b>" + jsonObj.Value1 + "</b><br/>" + jsonObj.Value2 + "<br/>" + jsonObj.Value3;
		}
	}

});