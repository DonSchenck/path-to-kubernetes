# Use the official maven/Java 8 image to create a build artifact.
# https://hub.docker.com/_/maven
FROM maven:3.5-jdk-8-alpine as builder

# Copy local code to the container image.
WORKDIR /app
COPY pom.xml .
COPY src ./src

# Build a release artifact.
RUN mvn clean package -DskipTests

# Use the Official OpenJDK image for a lean production stage of our multi-stage build.
# https://hub.docker.com/_/openjdk
# https://docs.docker.com/develop/develop-images/multistage-build/#use-multi-stage-builds
FROM openjdk:8-jre-alpine

# Install some fonts
ENV LANG en_US.UTF-8
RUN apk add --update ttf-dejavu ttf-droid ttf-freefont ttf-liberation && rm -rf /var/cache/apk/*

# Copy the jar to the production image from the builder stage.
COPY --from=builder /app/target/helloWorld-*.jar /helloWorld.jar

# Service must listen to $PORT environment variable.
# This default value facilitates local development.
ENV PORT 3333

# Run the web service on container startup.
CMD ["java","-Dserver.port=${PORT}","-jar","/helloWorld.jar"]