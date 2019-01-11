<?php
//opens connection to mysql server
$dbc = mysql_connect('localhost','','');
if (!$dbc) {
    die('Not connected': . mysql_error());
 }
 
//select database
$db_selected = mysql_select_db('', $dbc);
if (!$db_selected) {
  die ("can't connect : " .mysql_error());
}

//test
$query="UPDATE Location SET email='hopethisworks' WHERE username='chris'";
$result=mysql_query($query);
?>