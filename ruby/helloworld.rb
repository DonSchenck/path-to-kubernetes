require 'sinatra'

set :port, 3333

get '/' do
    'Hello World!'
end