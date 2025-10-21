# Event Management System

A complete Blazor WebAssembly standalone application built with .NET 9.0 for managing and registering for events.

###  EventCard Component with Two-Way Data Binding
- **Two-way binding implementation**: `[Parameter]` attributes with `EventCallback` for change notifications
- **Real-time updates**: Highlight toggle feature demonstrating parent-child communication
- **Interactive elements**: Dynamic UI responses to user interactions

###  Routing Functionality
- **Multiple routes**: Home page (`/`) and EventDetails page (`/event-details/{EventId:int}`)
- **Parameterized routing**: Strongly typed route parameters for event details
- **Navigation**: Clean navigation between application sections

###  Performance Optimization
- **Efficient service lifetimes**: Singleton for event data, scoped for user sessions
- **Validation optimization**: Client-side DataAnnotations preventing unnecessary server calls
- **Rendering optimization**: Proper component lifecycle management

###  Advanced Features
- **Registration Form with Validation**: Comprehensive DataAnnotations (`[Required]`, `[EmailAddress]`, `[Range]`, `[Phone]`, `[StringLength]`)
- **State Management**: UserSessionService tracking user registrations across components
- **Attendance Tracker**: Real-time progress indicators with visual capacity tracking

## Features
- **Event Listing**: Browse all available events with filtering options
- **Event Details**: View comprehensive information about each event
- **Registration System**: Complete form validation with DataAnnotations
- **Real-Time Attendance Tracking**: Live progress indicators for event capacity
- **Two-Way Data Binding**: Demonstrated in EventCard component with highlighting feature
- **Routing**: Clean navigation with route parameters
- **Session Management**: Track user registrations across the application
- **Responsive Design**: Custom CSS that works on all devices

## Technical Specifications
- **.NET 9.0** Blazor WebAssembly (standalone)
- **In-Memory Data Storage**: No database required
- **Custom CSS**: No Bootstrap or external frameworks
- **Client-Side Rendering**: Pure WebAssembly execution


## Running the Application

```bash
dotnet run
