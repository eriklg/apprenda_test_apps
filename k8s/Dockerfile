FROM openjdk:8-jre-alpine
COPY ./javatester.war /javatester.war

ENTRYPOINT ["java", "-jar", "-Djava.security.egd=file:/dev/./urandom", "/javatester.war"]
