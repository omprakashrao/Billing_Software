SET IDENTITY_INSERT [dbo].[AONE_TABLE] ON
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (1, N'king bed 6x6', 15000, 500)
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (2, N'king bed 5x6', 14000, 400)
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (3, N'deewan bed', 7000, 550)
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (2006, N'sofa singe seat', 4500, 250)
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (2007, N'sofa two seat', 8000, 400)
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (2008, N'chair', 3500, 200)
INSERT INTO [dbo].[AONE_TABLE] ([item_id], [item_name], [item_price], [item_discount]) VALUES (2009, N'waedrobe', 16000, 1500)
SET IDENTITY_INSERT [dbo].[AONE_TABLE] OFF

update AONE_TABLE set item_name='stool', item_price=4000,item_discount=300 where item_id=2008; 