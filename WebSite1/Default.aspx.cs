using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    ArrayList PageArrayList;

    ArrayList CreateArray()
    {
        // Create a sample ArrayList.
        ArrayList result = new ArrayList(4);

        result.Add("item 1");
        result.Add("item 2");
        result.Add("item 3");
        result.Add("item 4");

        return result;
    }
    void Page_PreRender(object sender, EventArgs e)
    {
        PageArrayList = CreateArray();
        // Save PageArrayList before the page is rendered.
        ViewState.Add("arrayListInViewState", PageArrayList);
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}