<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/256585142/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T883539)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Dashboard for WinForms - How to display sales by years in comparison with the previous year's sales

This example shows how to display sales by years in comparison with the previous year's sales.

## Example Structure

The *Previous Year Sales* Grid displays sales by year in comparison with the previous year’s sales. The *PrevYearSales* field is calculated by the following expression:

```
aggr(Sum([Sales]), joinRule(GetYear([OrderDate]),GetYear([OrderDate])-1))
```

The [joinRule](https://docs.devexpress.com/Dashboard/115870/common-features/advanced-analytics/aggregations/intermediate-level-aggregations#shift-the-calculation-level) function here is used to shift the calculated sales back a year. Add the created field to the Grid’s Columns section to see the result:

![screenshot](/images/aggr-joinRule-PrevYearSales.png)


The second Grid, *Product Sales by Quarters*, displays quarterly sales numbers in comparison with corresponding quarterly numbers from the previous year.

The *PrevQuarterYearSales* calculated field aggregates sales by products and the previous year’s quarter. The [joinRule](https://docs.devexpress.com/Dashboard/115870/common-features/advanced-analytics/aggregations/intermediate-level-aggregations#shift-the-calculation-level) function is used to calculate the second dimension.

```
aggr(Sum([Sales]),[ProductName],joinRule(GetDateQuarterYear([OrderDate]),GetDateQuarterYear(AddYears([OrderDate], -1))))
```

A format rule is applied to highlight sales that declined in comparison to the previous year:

![screenshot](/images/aggr-joinRule-PrevQuarterYearSales.png)

## Files to Review

* [Form1.cs](./CS/Dashboard_PrevYearData/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_PrevYearData/Form1.vb))

## Documentation

- [Intermediate Level Aggregations](https://docs.devexpress.com/Dashboard/115870/)
- [Aggregations](https://docs.devexpress.com/Dashboard/115894/)
- [Expression Constants, Operators, and Functions](https://docs.devexpress.com/Dashboard/400122/)

## More Examples

- [Dashboard for WinForms - How to display best and worst monthly sales for each year](https://github.com/DevExpress-Examples/how-to-display-best-and-worst-monthly-sales-for-each-year-t369371)
- [Dashboard for WinForms - How to Calculate the Contribution of Quarterly Sales to Total Yearly Sales](https://github.com/DevExpress-Examples/how-to-calculate-the-contribution-of-quarterly-sales-to-total-yearly-sales)
- [Dashboard for WinForms - How to evaluate a customer acquisition using the quarter/year of their first purchase](https://github.com/DevExpress-Examples/how-to-divide-customers-count-by-the-number-of-orders-they-made-t372356)
- [Dashboard for WinForms - How to divide customers' count by the number of orders they made](https://github.com/DevExpress-Examples/how-to-divide-customers-count-by-the-number-of-orders-they-made-t372356)
- [Dashboard for WinForms - How to calculate Highest Product Sales by Year](https://github.com/DevExpress-Examples/how-to-show-products-with-the-best-sales-in-a-year-along-with-sales-values-t372408)
- [Dashboard for WinForms - How to Display Product Sales that are Greater than $20k](https://github.com/DevExpress-Examples/How-to-Display-Product-Sales-that-are-Greater-than-20k)
- [Dashboard for WinForms - How to Display Products with Sales Greater than Average Sales per Category](https://github.com/DevExpress-Examples/How-to-Display-Product-with-Sales-Greater-than-Average-Sales-per-Category)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=win-dashboard-display-previous-year-sales&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=win-dashboard-display-previous-year-sales&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
