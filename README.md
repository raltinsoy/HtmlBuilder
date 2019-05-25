# Html Builder

Examle

```c#
var tableStyle = new TableStyle()
    {
        Width = "100%",
        BackgroundColor = "gray",
        Border = "1px solid red"
    };

var testBuilder = Builder.Create().AddTable(
    new Table(tableStyle: tableStyle)
        .AddTr(new Tr()
            .AddChildToTr(new Th("Row1.Col1"))
            .AddChildToTr(new Th("Row1.Col2"))
        )
        .AddTr(new Tr()
            .AddChildToTr(new Td("Row2.Col1"))
            .AddChildToTr(new Td("Row2.Col2"))
        )
    ).SerializeToString();
```
