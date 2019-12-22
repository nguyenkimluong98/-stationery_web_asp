<%@ Application Language="C#" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Web" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        string path = Server.MapPath("~") + "/thongke.txt";
        if (!File.Exists(path))
            File.WriteAllText(path, "0");
        Application["DaTruyCap"] = int.Parse(File.ReadAllText(path)); 
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        string path = Server.MapPath("~") + "/thongke.txt";

        File.WriteAllText(path, Application["DaTruyCap"].ToString());
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
        Session["SomeData"] = 1;
        string path = Server.MapPath("~") + "/thongke.txt";
        if (Application["DangOnline"] == null)
            Application["DangOnline"] = 0;
        else
            Application["DangOnline"] = (int)Application["DangOnline"] + 1;

        Application["DaTruyCap"] = (int)Application["DaTruyCap"] + 1;
        File.WriteAllText(path, Application["DaTruyCap"].ToString());
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
        int i = (int)Application["DangOnline"];
        if (i >= 1)
            Application["DangOnline"] = i - 1;

        string path = Server.MapPath("~") + "/thongke.txt";
        File.WriteAllText(path, Application["DaTruyCap"].ToString()); 
    }
       
</script>
