# Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

# The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.

# It is much easier to understand with an example:

# format_duration(62)    returns "1 minute and 2 seconds"
# format_duration(3662)  returns "1 hour, 1 minute and 2 seconds"

def format_duration(seconds):
    if seconds == 0:
        return 'now'
    results = []
#     Floor division by the number of seconds in a year to get the years
#     Find the remainder to get days
    years = seconds // (365 * 24 * 3600)
    if years > 0:
        results.append(f'{years} years' if years > 1 else '1 year')
    seconds = seconds % (365 * 24 * 3600)
    
#     Floor division by seconds in a day
    days = seconds // (24 * 3600)
    if days > 0:
        results.append(f'{days} days' if days > 1 else '1 day')
    seconds = seconds % (24 * 3600)
    
#     Floor divison by seconds in an hour
    hours = seconds // 3600
    if hours > 0:
        results.append(f'{hours} hours' if hours > 1 else '1 hour')
    seconds = seconds % 3600
    
    minutes = seconds // 60
    if minutes > 0:
        results.append(f'{minutes} minutes' if minutes > 1 else '1 minute')
    seconds = seconds % 60
    if seconds > 0:
        results.append(f'{seconds} seconds' if seconds > 1 else '1 second')
        
    
    return ', '.join(results[:-1]) + ' and ' + results[-1] if len(results) > 1 else results[0]
    
print(format_duration(81751984))