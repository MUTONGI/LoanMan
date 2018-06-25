<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1">
   
   <%--<script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>--%>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="Scripts/DataTables/dataTables.bootstrap4.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.js"></script> 
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.js"></script> 
    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha/css/bootstrap.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.css" rel="stylesheet"> 
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="include/css/style.css" rel="stylesheet" />
    <script src="include/javascript/loanman.main.js"></script>
   <title>LoanMan</title>
</head>
<body>
    <div id='cssmenu'>
        <ul>
           <li><a href='#'><span>Home</span></a></li>
           <li class='active has-sub'><a href='#'><span>Clients</span></a>
              <ul>
                 <li class='has-sub'><a href='#'><span>Add New Client</span></a></li>
                 <li class='has-sub'><a href='#'><span>Edit Client</span></a></li>
              </ul>
           </li>
           <li><a href='#'><span>Loan</span></a></li>
           <li class='last'><a href='#'><span>Reports</span></a></li>
            <li><a href='#'><span>Admin</span></a></li>
           <li class='last'><a href='#'><span>Settings</span></a></li>
        </ul>
    </div>
    <div id="Content">

    </div>
    <script>
        loanman.main.initialiseMain();
    </script>
</body>
</html>