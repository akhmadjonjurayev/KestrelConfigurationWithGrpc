using Grpc.Core;
using GrpcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.GrpcService
{
    public class BaseGrpcService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply() { Message = "Hello " + request.Name });
        }
    }
}
