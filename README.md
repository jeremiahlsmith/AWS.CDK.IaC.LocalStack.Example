# AWS Practice - IaC Code Deployment using Localstack

This is a practice application to deploy AWS lambdas, with associated API gateway (REST API Endpoints), of foo and bar to a localstack instance.

## Links

* [YouTube Video Reference](https://www.youtube.com/watch?v=5aBf0W0_FDY&t=606s)
* [LocalStack](https://localstack.cloud/)
* [AWS CDK Local](https://github.com/localstack/aws-cdk-local)
* [AWS CLI Local](https://github.com/localstack/awscli-local)


## Useful commands

* `dotnet build src` compile this app
* `dotnet publish src` publish app to folder
* `cdklocal deploy`       deploy this stack to your default AWS account/region
* `cdklocal diff`         compare deployed stack with current state
* `cdklocal deploy`        deploy application to localstack instance
