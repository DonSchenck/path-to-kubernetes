FROM python:3.7
ADD helloworld.py /
RUN pip install --user flask
RUN pip install --user flask_restful
EXPOSE 3333
CMD [ "python", "./helloworld.py"]