# WorkflowExample - test2

# build docker image manually
docker build -f Dockerfile.Server -t demo-workflow-server:v1.0.0 .

# run docker containers
docker run --rm -it -p 7001:7001 demo-workflow-server:v1.0.0

