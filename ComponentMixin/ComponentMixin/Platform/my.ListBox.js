
/**
 * my.ListBox
 */
qx.Class.define("my.ListBox", {

        extend: wisej.web.ListBox,

        construct: function() {

            this.base(arguments);

            this.setItemAppearance("my-listitem");
        },

});
