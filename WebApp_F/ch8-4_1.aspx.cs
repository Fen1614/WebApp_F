using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_F {
    public partial class ch8_4_1 : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ddl_Sort_SelectedIndexChanged(object sender, EventArgs e) {
            gv_Show.Sort(ddl_Sort.SelectedValue, SortDirection.Descending);
        }

    }
}