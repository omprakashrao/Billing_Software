SET IDENTITY_INSERT [dbo].[orderTable] ON
INSERT INTO [dbo].[orderTable] ([Id], [invoice_id], [item_name], [unit_price], [discount_per_item], [quantity], [subtotal], [tax], [total_cost]) VALUES (1, 101, N'king bed 6x6', 15000, 500, 1, 14500, 2610, 17110)
INSERT INTO [dbo].[orderTable] ([Id], [invoice_id], [item_name], [unit_price], [discount_per_item], [quantity], [subtotal], [tax], [total_cost]) VALUES (2, 101, N'deewan bed', 7000, 550, 1, 6450, 1161, 7611)
INSERT INTO [dbo].[orderTable] ([Id], [invoice_id], [item_name], [unit_price], [discount_per_item], [quantity], [subtotal], [tax], [total_cost]) VALUES (3, 102, N'king bed 6x6', 15000, 500, 1, 14500, 2610, 17110)
INSERT INTO [dbo].[orderTable] ([Id], [invoice_id], [item_name], [unit_price], [discount_per_item], [quantity], [subtotal], [tax], [total_cost]) VALUES (4, 102, N'deewan bed', 7000, 550, 1, 6450, 1161, 7611)
SET IDENTITY_INSERT [dbo].[orderTable] OFF
