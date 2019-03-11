require 'sinatra'

set :port, 3333
set :bind, '0.0.0.0'

get '/' do
    'Hello World!'
end