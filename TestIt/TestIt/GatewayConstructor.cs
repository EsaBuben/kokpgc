// ﻿using System;
//
// namespace TestIt
// {
//     public class GatewayConstructor:IGateway
//     {
//         private IGateway gateway;
//         public GatewayConstructor(DataObjectType dtype)
//         {
//         switch(dtype)
//           {
//           case DataObjectType.Project:
//             gateway = new ProjectGateway();
//             break;
//           case DataObjectType.Funktionality:
//             gateway = new FunctionalityGateway();
//             break;
//           case DataObjectType.Test:
//             gateway = new TestGateway();
//             break;
//           case DataObjectType.Result:
//             break;
//           case DataObjectType.User:
//             break;
//
//           }
//         }
//
//         public void Insert(obj){
//           gateway.Insert(obj);
//         }
//
//         public List<Object> SelectAll(){
//           return gateway.SelectAll();
//         }
//
//         public List<Object> SelectAll(int id){
//           return gateway.SelectAll(int id);
//         }
//
//
//     }
//
//
//
// }
