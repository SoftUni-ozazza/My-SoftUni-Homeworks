<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <link rel="stylesheet" href="Styles/01.rootSum.css"/>

    <title>Sum of Digits</title>
</head>
<body>
<article>
    Input string:
    <form method="post">
        <input type="text" name="digitsStr"/>
        <input type="submit" name="send" value="Submit"/>
    </form>
</article>

<?php
if (isset($_POST['digitsStr'])) {
    $digitsList = htmlentities($_POST['digitsStr']);
    $asString = preg_split('/[ ,]+/', $digitsList);
    $sum = 0;
    $result = 0;
    ?>
    <article>
        <table>

            <?php

            /*<!-- check each cell-input(string) in array -->*/
            foreach ($asString as $cell) {

                /*<!-- check if the cell in array is a number -->*/
                if (is_numeric($cell)) {

                    /*<!-- add cell as array -->*/
                    $dropCell = [$cell];

                    /*<!-- check it and use each char -->*/
                    foreach ($dropCell as $digit) {

                        /*<!-- split the cell(number but as string)
                        to chars(digits), all in array -->*/
                        $tableCells = str_split($digit);

                        foreach ($tableCells as $number) {

                            /*<!-- make each char to number and sum them -->*/
                            $sum += intval($number);
                        }
                        $result = $sum;
                        $sum = 0;
                    }
                    ?>

                    <!-- add integer and integers sum to HTML-->
                    <tr>
                        <td><?= $cell ?></td>
                        <td><?= $result?></td>
                    </tr>

                <?php

                /*<!-- check if the cell in array is a string -->*/
                } elseif (is_string($cell)) {
                    ?>
                    <!-- add string -->
                    <tr>
                        <td><?= $cell ?></td>
                        <td>Can't sum</td>
                    </tr>
                <?php
                }
            }
            ?>

        </table>
    </article>

<?php
}
?>

</body>
</html>