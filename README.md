# Html Builder

Examle

```c#
var testBuilder = Builder.Create()
                 .AddTr(new Tr()
                     .AddChildToTr(
                         new Th("Th1")
                     )
                     .AddChildToTr(
                         new Th("Th2")
                     )
                 )
                 .AddTr(new Tr()
                    .AddChildToTr(
                        new Td("Td1")
                     )
                     .AddChildToTr(
                        new Td("Td2")
                     )
                 )
                 .SerializeToString();
```
