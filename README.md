AS.BaseModel

Description:

Sample base template for integration model & entitys
This dll contains the following components:

namespaces(AS.BaseModels):

- BaseEntitys:

-- Abstract:

--> BaseEntity.cs (abstract class contains InsertDateTime & UpdateDateTime. Inherit from IBaseEntitys.cs)
--> EntityCode.cs (inherit from BaseEntity.cs & IEntityCode.cs)
--> EntityId.cs (inherit from BaseEntity.cs & IEntityId.cs)
--> PersonBaseEnity.cs (Sample person model inherit from EntityId.cs)

-- Interfaces:

-->IBaseEntity.cs (contains InsertDateTime & UpdateDateTime)
-->IEnittyId.cs (contains Id(Guid))
-->IEntityCode.cs (contains Code(byte))

How to Use: 

if your entitys need Guid Id you can inherit from (AS.BaseModels.BaseEntitys.EntityId(.cs))
if your entitys need byte Code can inherit from (AS.BaseModels.BaseEntitys.EntityCode(.cs))