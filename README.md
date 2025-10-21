# EventEase - Event Management System

A complete Blazor WebAssembly standalone application built with .NET 9.0 for managing and registering for events.

##  Grading Criteria Compliance

###  GitHub Repository Structure
- Clean project organization with proper folder structure
- All required components, pages, services, and models organized logically
- Ready for immediate GitHub submission

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

###  Copilot Usage Documentation
*Detailed below*

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

##  Copilot Development Documentation

### Activity 1: Component Generation with Copilot
**EventCard.razor**: Copilot generated the foundational structure with two-way binding patterns using `[Parameter]` and `EventCallback` for the highlight feature demonstration.

**RegistrationForm.razor**: Assisted in implementing comprehensive DataAnnotations validation system with proper error message binding and form submission handling.

**AttendanceTracker.razor**: Helped create real-time progress visualization with color-coded capacity indicators and percentage calculations.

### Activity 2: Debugging & Optimization with Copilot
**Routing Issues**: Identified and resolved route parameter type constraints, ensuring proper `{EventId:int}` parsing and navigation.

**Validation Implementation**: Debugged DataAnnotations attribute usage and corrected validation message display logic in the registration form.

**Performance Optimization**: Suggested proper service lifetime management (Singleton vs Scoped) and efficient state change notification patterns.

### Activity 3: Comprehensive Project Development
**Service Layer Architecture**: Generated EventService with in-memory data management and sample event initialization.

**State Management Pattern**: Assisted in implementing UserSessionService with event-based state change notifications across components.

**Component Integration**: Helped resolve data flow issues between EventCard, RegistrationForm, and AttendanceTracker components.

### Specific Copilot Contributions
- **Rapid Prototyping**: Accelerated development by generating complete component templates with proper Blazor syntax
- **Error Resolution**: Quickly identified missing using directives, improper parameter binding, and lifecycle method issues
- **Best Practices**: Suggested modern Blazor patterns for two-way binding, event handling, and component communication
- **Code Quality**: Ensured consistent coding standards and proper separation of concerns throughout the application

## Running the Application

```bash
dotnet run