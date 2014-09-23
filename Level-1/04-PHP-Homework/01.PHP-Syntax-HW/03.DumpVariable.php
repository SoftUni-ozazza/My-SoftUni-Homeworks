<!--
"hello"
15
1.234
array(1,2,3)
(object)[2,34]
-->

<?php
$input = "hello";
global $result;
if (is_numeric($input)) {
    $result = var_dump($input);
} elseif (!is_numeric($input)) {
    $result = gettype($input);
}
echo($result);

?>