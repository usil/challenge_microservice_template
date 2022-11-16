# challenge_microservice_template

initial starter with c# + myql

# one click run

```
docke-compose down
docke-compose up
```

# endpoints

**create user**

```
curl --location --request POST 'http://localhost:5000/v1/user' \
--header 'Content-Type: application/json' \
--data-raw '{
    "UserName":"Barney",
    "Hobbies":"Reichert",
    "Location":"gu"
}'
```

**list users**

```
curl --location --request GET 'http://localhost:5000/v1/user/' \
--header 'Content-Type: application/json' \
--data-raw '{
    "UserName":"Jonatan",
    "Hobbies":"Krajcik",
    "Location":"ast"
}'
```