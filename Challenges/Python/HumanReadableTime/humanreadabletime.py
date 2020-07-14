# Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

# HH = hours, padded to 2 digits, range: 00 - 99
# MM = minutes, padded to 2 digits, range: 00 - 59
# SS = seconds, padded to 2 digits, range: 00 - 59
# The maximum time never exceeds 359999 (99:59:59)

def make_readable(seconds):
    hours = int(seconds/3600) if seconds >= 3600 else '00'
    minutes = int((seconds%3600)/60) if seconds >= 60 else '00'
    seconds = int((seconds%3600)%60)
    time = [hours,minutes,seconds]
    for i in range(len(time)):
        if len(str(time[i])) < 2:
            time[i] = f'0{time[i]}'
    print(time)
    return f'{time[0]}:{time[1]}:{time[2]}'

print(make_readable("00:00:00"))
print(make_readable("00:00:05"))
print(make_readable("00:01:00"))
print(make_readable("23:59:59"))
print(make_readable("99:59:59"))