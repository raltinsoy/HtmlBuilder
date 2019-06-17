# Html Builder

[![Build status](https://ci.appveyor.com/api/projects/status/xwx68c63k8xlhejx?svg=true)](https://ci.appveyor.com/project/raltinsoy/htmlbuilder)

Examle usage

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
                        .AddChild(new Th("First Name"))
                        .AddChild(new Th("Last Name"))
                    )
                    .AddTr(new Tr()
                        .AddChild(new Td("Peter"))
                        .AddChild(new Td("White"))
                    )
                ).SerializeToString();
```

```c#
var testBuilder = Builder.Create()
                .AddTable(x => x.AddTr(y => y
                                            .AddChild(new Td("Id"))
                                            .AddTd("Fisrt Name")
                                            .AddTd(new Td("Last Name"))
                                       )
                                .AddTr(y => y
                                            .AddChild(new Th("1"))
                                            .AddTh("Peter")
                                            .AddTh(new Th("White"))
                                       )
                                .AddTr(y => y
                                            .AddChild(new Th("2"))
                                            .AddTh("Bob")
                                            .AddTh(new Th("Marley"))
                                       )
                          )
                .SerializeToString();
```
