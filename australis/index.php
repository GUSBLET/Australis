<?php

//print_r($_SERVER);

include_once ("main.php");
include_once ("gallery.php");
include_once ("description.php");




if(($_SERVER['REQUEST_URI'] == "/" || $_SERVER['REQUEST_URI'] == "/index.php" )) {
echo $main;
    }

elseif($_SERVER['REQUEST_URI'] == "/gallery") {
echo $gallery;
    }
    
elseif($_SERVER['REQUEST_URI'] == "/description") {
echo $description;
    }





elseif($_SERVER['REQUEST_URI'] == "/instagram") {
header('Location: https://instagram.com/australis_kiev?utm_medium=copy_link');
    }


?>