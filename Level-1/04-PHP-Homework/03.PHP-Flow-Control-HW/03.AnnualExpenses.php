<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <link href="Styles/01.rootSum.css" rel="stylesheet"/>
    <title>Annual Expenses</title>
</head>
<body>
<section>
    <article>
        <p>Enter number of years:</p>
        <form method="post">
            <input type="text" name="years"/>
            <input type="submit" name="submit button" value="Show costs"/>
        </form>

        <?php
        $thisYear = idate('Y') + 1;
        $sumExpenses = 0;

        if (isset($_POST['years'])) {
        $userYears = htmlentities($_POST['years']);
        ?>

    </article>
    <article>
        <table>
            <tr>
                <th>Year</th>
                <th>Jan</th>
                <th>Feb</th>
                <th>Mar</th>
                <th>Apr</th>
                <th>May</th>
                <th>Jun</th>
                <th>Jul</th>
                <th>Aug</th>
                <th>Sep</th>
                <th>Oct</th>
                <th>Nov</th>
                <th>Dec</th>
                <th>Total:</th>
            </tr>

            <?php
            for ($y = 0; $y < $userYears; $y++) {
            ?>

                <tr>
                    <td><?= $thisYear - 1; ?></td>

                    <?php
                    for ($i = 0; $i < 12; $i++) {
                        $randomExpenses = rand(0, 999);
                    ?>

                        <td><?= $randomExpenses ?></td>

                    <?php
                        $sumExpenses += $randomExpenses;
                    }
                    ?>
                    <td><?= $sumExpenses ?></td>
                </tr>

            <?php
                $thisYear--;
                }
            }
            ?>
        </table>
    </article>
</section>
</body>
</html>