# Online Car Ordering Program

## Overview
The Online Car Ordering Program is a C# based application that provides a seamless way for passengers to book rides and for drivers to select trips. This application features a real-time chat system allowing passengers and drivers to communicate directly, enhancing the ride experience. It utilizes Firebase as a real-time database to ensure quick and efficient data handling.

## Features
- **Trip Booking**: Passengers can enter their destination and trip price to book a ride.
- **Driver Trip Selection**: Drivers can choose from a list of available trips.
- **Real-Time Notifications**: Passengers are alerted when a driver accepts their delivery request.
- **In-App Chat**: A conversation interface is opened between the passenger and driver upon trip acceptance.
- **Firebase Integration**: Utilizes Firebase for real-time database management.


### Installation

1. **Clone the Repository**
    ```bash
    git clone https://github.com/yourusername/online-car-ordering-program.git
    cd online-car-ordering-program
    ```

2. **Open in Visual Studio**
   Open the solution file (`.sln`) in Visual Studio.
   
## Usage

1. **Passenger Interface**
   - Enter the destination and price of the trip.
   - Submit the trip request.

2. **Driver Interface**
   - View the list of available trips.
   - Select a trip to accept.

3. **Real-Time Interaction**
   - Upon trip acceptance, the passenger receives an alert.
   - A chat window is opened for communication between the passenger and driver.

## Project Structure

```
OnlineCarOrdering/
│
├── OnlineCarOrdering.sln
├── README.md                       # Project README file
├───┬── OnlineCarOrderingApp        # Main application directory
│   ├── Form1.cs                    # The program's home page for login
│   ├── signup_frm.cs               # The page for creating a new account
│   ├── welcome_frm.cs              # User welcome page
│   │
│   ├──┬── passenger_form.cs        # passenger form to Enter trip data
│   │  └── request_accept_form.cs   # Trip acceptance page, It contains driver,car data and chat
│   │
│   └──┬── driver_frm.cs            # Driver form to view and choose the trip
│      └── driver_acc_form.cs       # Trip acceptance page, It contains Passenger,trip data and chat
│
└──────┬── /classes/                # contains data that will be transferred to Firebase
       ├── driver_dt.cs             # Driver data
       ├── user_dt.cs               # Passenger data
       └── requests.cs              # Passenger Request data

```


## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a pull request.
