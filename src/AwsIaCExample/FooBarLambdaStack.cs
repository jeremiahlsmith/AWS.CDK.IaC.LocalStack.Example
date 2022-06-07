using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.APIGateway;


namespace AwsIaCExample
{
    public class FooBarLambdaStack : Stack
    {
        internal FooBarLambdaStack(Amazon.CDK.Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // The code that defines your stack goes here
            var fooLambda = new Function(this, "fooLambda", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("src/AWS.IaC.Lambda.Foo/bin/Debug/netcoreapp3.1/publish"),
                Handler = "AWS.IaC.Lambda.Foo::AWS.IaC.Lambda.Foo.Functions::Get"
            });

            new LambdaRestApi(this, "fooApiEndpoint", new LambdaRestApiProps()
            {
                Handler = fooLambda
            });

            var barLambda = new Function(this, "barLambda", new FunctionProps()
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("src/AWS.IaC.Lambda.Bar/bin/Debug/netcoreapp3.1/publish"),
                Handler = "AWS.IaC.Lambda.Bar::AWS.IaC.Lambda.Bar.Functions::Get"
            });

            new LambdaRestApi(this, "barApiEndpoint", new LambdaRestApiProps()
            {
                Handler = barLambda
            });
        }
    }
}
