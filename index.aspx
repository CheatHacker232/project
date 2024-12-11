<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <link href="StyleSheet.css" rel="stylesheet" />
    <form id="form1" runat="server">
    <h1>Welcome to Abra</h1>
    <div>
        <label>Name:</label>
        <input type="text" name="fname" id="fname" placeholder="Enter your name" required="required"/>
    </div>

    <div>
        <label>Email:</label>
        <input type="text" name="email" id="email" placeholder="Example@email.com" required="required" />
    </div>

    <div>
        <label>Occupation:</label>
        <input type="text" name="occupation" id="occupation" placeholder="Enter your workfield name" required="required" />
    </div>

    <div>
        <label>Quantity:</label>
        <input type="number" name="quantity" id="quantity" min="1" max="50" value="1" required="required" />
    </div>

    <div>
        <input type="submit" class="btn" value="Submit" name="Submit" />
    </div>

    <div>
        <input type="reset" class="btn" value="Reset" name="Reset"/>
    </div>
            <div>
        <a href="DataBase.aspx">
            <input type="button" class="btn" name="DataBase" value="DataBase"/>
        </a>
    </div>
        <%=msg%>

    </form>
</body>
</html>
