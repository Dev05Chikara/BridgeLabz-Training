CREATE DATABASE HealthClinicDB;
GO
USE HealthClinicDB;
GO
CREATE TABLE Specialties (
    SpecialtyId INT IDENTITY PRIMARY KEY,
    SpecialtyName NVARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE Doctors (
    DoctorId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    SpecialtyId INT,
    Contact NVARCHAR(20),
    ConsultationFee DECIMAL(10,2) NOT NULL,
    IsActive BIT DEFAULT 1,
    FOREIGN KEY (SpecialtyId) REFERENCES Specialties(SpecialtyId)
);
CREATE TABLE Patients (
    PatientId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    DOB DATE NOT NULL,
    Phone NVARCHAR(20) UNIQUE,
    Email NVARCHAR(150) UNIQUE,
    Address NVARCHAR(250),
    BloodGroup NVARCHAR(10)
);
CREATE TABLE Appointments (
    AppointmentId INT IDENTITY PRIMARY KEY,
    PatientId INT,
    DoctorId INT,
    AppointmentDate DATE,
    AppointmentTime TIME,
    Status NVARCHAR(20) DEFAULT 'SCHEDULED',
    FOREIGN KEY (PatientId) REFERENCES Patients(PatientId),
    FOREIGN KEY (DoctorId) REFERENCES Doctors(DoctorId)
);
CREATE TABLE Visits (
    VisitId INT IDENTITY PRIMARY KEY,
    AppointmentId INT,
    Diagnosis NVARCHAR(500),
    Notes NVARCHAR(500),
    VisitDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (AppointmentId) REFERENCES Appointments(AppointmentId)
);
CREATE TABLE Prescriptions (
    PrescriptionId INT IDENTITY PRIMARY KEY,
    VisitId INT,
    MedicineName NVARCHAR(150),
    Dosage NVARCHAR(100),
    Duration NVARCHAR(100),
    FOREIGN KEY (VisitId) REFERENCES Visits(VisitId)
);
CREATE TABLE Bills (
    BillId INT IDENTITY PRIMARY KEY,
    VisitId INT,
    TotalAmount DECIMAL(10,2),
    PaymentStatus NVARCHAR(20) DEFAULT 'UNPAID',
    PaymentDate DATETIME,
    PaymentMode NVARCHAR(50),
    FOREIGN KEY (VisitId) REFERENCES Visits(VisitId)
);
CREATE TABLE PaymentTransactions (
    TransactionId INT IDENTITY PRIMARY KEY,
    BillId INT,
    Amount DECIMAL(10,2),
    TransactionDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (BillId) REFERENCES Bills(BillId)
);
CREATE TABLE AuditLog (
    LogId INT IDENTITY PRIMARY KEY,
    TableName NVARCHAR(100),
    ActionType NVARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);