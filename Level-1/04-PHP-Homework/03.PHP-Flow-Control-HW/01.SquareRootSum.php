<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <link href="Styles/01.rootSum.css" rel="stylesheet"/>
    <title>Square Root Sum</title>
</head>
<body>
<article>
    <table>
        <thead>
        <tr>
            <th>Number</th>
            <th>Square Root</th>
        </tr>
        </thead>
        <tbody>

        <?php
        $sum = 0;
        for ($i = 0; $i < 101; $i++) :
            if ($i % 2 == 0) :
                $sqrt = round(sqrt($i), 2);
                $sum += $sqrt;
                ?>
                <tr>
                    <td><?= $i ?></td>
                    <td><?= $sqrt ?></td>
                </tr>
            <?php
            endif;
        endfor;
        ?>

        </tbody>
        <tfoot>
        <tr>
            <td>Total:</td>
            <td><?= $sum ?></td>
        </tr>
        </tfoot>

    </table>
</article>
</body>
</html>