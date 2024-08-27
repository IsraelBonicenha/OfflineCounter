using OfflineCounter.uClass;

ManagerDisplay managerDisplay = new ManagerDisplay();
managerDisplay.Display_Inicial();

bool encerrar_program = false;

while (!encerrar_program)
{
    ManagerValidator managerValidator = new ManagerValidator();
    encerrar_program = managerValidator.Validate_KeyPress_One();
}
