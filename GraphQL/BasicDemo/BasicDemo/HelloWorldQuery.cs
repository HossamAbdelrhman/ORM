﻿using BasicDemo.CustomField;
using GraphQL.Types;

namespace BasicDemo
{
    public class HelloWorldQuery : ObjectGraphType
    {
        public HelloWorldQuery()
        {
            Field<StringGraphType>(
                name: "hello",
                resolve: context => "world"
            );
            Field<StringGraphType>(
                name: "howdy",
                resolve: context => "universe"
            );


            Field<ItemType>(
                "item",
                resolve: context =>
                {
                    return new Item
                    {
                        Barcode = "123",
                        Title = "Headphone",
                        SellingPrice = 12.99M
                    };
                }
            );
            Field<ItemType>(
                "qitem",
                arguments: new QueryArguments
                (new QueryArgument<NonNullGraphType<StringGraphType>>
                { Name = "barcode" }),
                resolve: context =>
                {
                    var barcode = context.GetArgument<string>("barcode");
                    return new DataSource().GetItemByBarcode(barcode);
                }
            );
        }

    }
}
