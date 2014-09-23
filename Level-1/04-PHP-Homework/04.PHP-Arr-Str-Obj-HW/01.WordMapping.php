<?php
header("Content-Type: text/html; charset=UTF-8");
mb_internal_encoding("UTF-8");
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <link href="Styles/styles.css" rel="stylesheet"/>
    <title>Word Mapping</title>
</head>
<body>
<article>
    <form method="post">
        <textarea name="textInput"></textarea>
        <input type="submit" name="submitInput" value="Count Words"/>
    </form>
</article>
<?php
if (isset($_POST['submitInput'])) {
if (!empty($_POST['textInput'])) {
?>
<article>
    <table>
        <thead>
        <tr>
            <th>Word</th>
            <th>Times Count</th>
        </tr>
        </thead>
        <tbody>

        <?php
        $textarea = htmlentities($_POST['textInput']);

        // for cyrillic encoding, assume the string as UTF-8 encoding
        $textToWords = mb_strtolower($textarea, 'UTF-8');
        $textToWords = preg_split('/["\s"."+ "!" "\/"+ ","+ "\""+ "-"+ "+"+ "="+ ]+/', $textToWords, 0, PREG_SPLIT_NO_EMPTY);

        // count the values at the array
        $countedValues = array_count_values($textToWords);

        // and print the array as keys and values
        foreach ($countedValues as $key => $value) {
            ?>
            <tr>
                <td><?= $key ?></td>
                <td><?= $value ?></td>
            </tr>

        <?php
        }
        } else {
            echo "<article>Please, add text!</article>";
        }
        }
        ?>
        </tbody>
    </table>
</article>

</body>
</html>