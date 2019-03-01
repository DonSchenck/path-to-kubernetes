FROM node:8
WORKDIR /app
COPY package*.json  ./
RUN npm install
COPY . .
EXPOSE 3333
CMD ["node", "app.js"]
