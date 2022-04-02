# Logger

## Integration

## Usage

## Creating an channel

All you have to do is creating a Class which implements the IChannel Interface, which gets delivered with the dll/NuGet package.

## Adding your channel

The Instance provided by the LogManager has a method called AddChannel() requiring a name and the IChannel object. As long as your Loginstance doesn't already contain a channel with the given name, it will add the channel.