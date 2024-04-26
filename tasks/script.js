document.getElementById("loginForm").addEventListener("submit", function(event) {
    // Prevent default form submission
    event.preventDefault();
    
    // Simulate login (You can replace this with actual login logic)
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
  
    // Check if username and password are correct (for demo, we assume it's correct)
    if (username === "demo" && password === "password") {
      // Hide login container
      document.getElementById("loginContainer").style.display = "none";
      // Show welcome container
      document.getElementById("welcomeContainer").style.display = "block";
    } else {
      // If username or password is incorrect, show an alert (for demo)
      alert("Incorrect username or password. Please try again.");
    }
  });
  